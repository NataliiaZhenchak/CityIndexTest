#!/usr/bin/env bash


if [ "$APPCENTER_XAMARIN_CONFIGURATION" == "Debug" ];then




    echo "Post Build Script Started"

    

    SolutionFile=`find "$APPCENTER_SOURCE_DIRECTORY" -name CityIndex.sln`

    SolutionFileFolder=`dirname $SolutionFile`




    UITestProject=`find "$APPCENTER_SOURCE_DIRECTORY" -name CityIndex.Automation.csproj`




    echo SolutionFile: $SolutionFile

    echo SolutionFileFolder: $SolutionFileFolder

    echo UITestProject: $UITestProject

    chmod -R 777 $SolutionFileFolder
    msbuild "$UITestProject" /property:Configuration=$APPCENTER_XAMARIN_CONFIGURATION



    UITestDLL=`find "$APPCENTER_SOURCE_DIRECTORY" -name "CityIndex.Automation.dll" | grep bin`

    echo UITestDLL: $UITestDLL




    UITestBuildDir=`dirname $UITestDLL`

    echo UITestBuildDir: $UITestBuildDir




    UITestVersionNumber=`grep '[0-9]' $UITestProject | grep Xamarin.UITest|grep -o '[0-9]\{1,3\}\.[0-9]\{1,3\}\.[0-9]\{1,3\}\.[0-9]\{1,10\}\-'dev`

    echo UITestPrereleaseVersionNumber: $UITestVersionNumber




    UITestVersionNumberSize=${#UITestVersionNumber} 

    echo UITestVersionNumberSize: $UITestVersionNumberSize




    if [ $UITestVersionNumberSize == 0 ]

    then

        UITestVersionNumber=`grep '[0-9]' $UITestProject | grep Xamarin.UITest|grep -o '[0-9]\{1,3\}\.[0-9]\{1,3\}\.[0-9]\{1,3\}'`

        echo UITestVersionNumber: $UITestVersionNumber

    fi




    TestCloudExe=`find ~/.nuget | grep test-cloud.exe | grep $UITestVersionNumber | head -1`

    echo TestCloudExe: $TestCloudExe




    TestCloudExeDirectory=`dirname $TestCloudExe`

    echo TestCloudExeDirectory: $TestCloudExeDirectory




    APKFile=`find "$APPCENTER_SOURCE_DIRECTORY" -name *.apk | head -1`




    #npm install -g appcenter-cli




    appcenter login --token 132d433074220a6d4fd3583b81a38bbe4b0c8466




    appcenter test run uitest --app "natalya.zhenchak-gmail.com/Xamarin.Android" --devices "f669a62b" --app-path $APKFile --test-series "master" --locale "en_US" --build-dir /$UITestBuildDir --uitest-tools-dir $TestCloudExeDirectory --async

fi
