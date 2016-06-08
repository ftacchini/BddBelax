"%~dp0\packages\NUnit.Runners.2.6.4\tools\nunit-console.exe" /out=TestResult.txt /xml=TestResult.xml /framework=net-4.5 MathOperations.AcceptanceTests\bin\Release\AccptanceTests.dll
 
"%~dp0\packages\SpecFlow.2.1.0\tools\specflow.exe" nunitexecutionreport MathOperations.AcceptanceTests\MathOperations.AcceptanceTests.csproj
 
IF NOT EXIST TestResult.xml GOTO FAIL
IF NOT EXIST TestResult.html GOTO FAIL
EXIT
 
:FAIL
echo ##teamcity[buildStatus status='FAILURE']
EXIT /B 1