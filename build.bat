@echo off
setlocal enableextensions
rmdir "Compiled\Networking\Messages"
rmdir "Compiled\Networking\"
rmdir "Compiled\Data\"
rmdir "Compiled\JS\"
rmdir "Compiled\"
md "Compiled\Networking\Messages"
md "Compiled\Data"
md "Compiled\JS"
protoc -I="." --csharp_out="Compiled/Networking/" Networking/*.proto --csharp_opt=file_extension=.g.cs
protoc -I="." --csharp_out="Compiled/Networking/Messages/" Networking/Messages/*.proto --csharp_opt=file_extension=.g.cs
protoc -I="." --csharp_out="Compiled/Data/" Data/*.proto --csharp_opt=file_extension=.g.cs

protoc --js_out=import_style=commonjs,binary:Compiled/JS Data/*.proto Networking/*.proto Networking/Messages/*.proto

