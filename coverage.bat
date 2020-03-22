rem ===========================================================================
rem OpenCover.bat
rem ===========================================================================

rem ===========================================================================
rem Tool path

set MSTEST="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe"
set OPENCOVER="packages\OpenCover.4.7.922\tools\OpenCover.Console.exe"
set REPORTGEN="packages\ReportGenerator.4.5.2\tools\net47\ReportGenerator.exe"

rem ===========================================================================
rem target informations

rem test target
set TEST_TARGET="Aoe2AISharp\bin\Debug\Aoe2AISharp.exe"

rem Open Cover parameters
set TARGET=%TEST_TARGET%
set TARGET_DIR="Aoe2AISharp\bin\Debug"
set TARGET_ARG=
set OPENCOVER_RESULT="coverage.xml"

rem output ReportGenerator result directory
set OUTPUT_DIR="Coverage"

rem target filter
set FILTERS="+[*]* -[*]*.Properties.* -[*]*.Tests.*"

rem ===========================================================================
%OPENCOVER% -register:user -target:%TARGET% -targetargs:%TARGET_ARG%  -targetdir:%TARGET_DIR% -filter:%FILTERS% -output:%OPENCOVER_RESULT%
%REPORTGEN% -reports:%OPENCOVER_RESULT% -targetdir:%OUTPUT_DIR%

%OUTPUT_DIR%\index.htm
