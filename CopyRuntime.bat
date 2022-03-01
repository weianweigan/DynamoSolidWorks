set path=%~d0
cd %path%
cd /d %~dp0
copy .\DynamoRuntime\* .\bin\Debug\ 