#!/usr/bin/env bash
mkdir -p "Compiled\Networking\Messages"
mkdir -p "Compiled\Data"
protoc -I="." --csharp_out="Compiled/Networking/" Networking/*.proto --csharp_opt=file_extension=.g.cs
protoc -I="." --csharp_out="Compiled/Networking/Messages/" Networking/Messages/*.proto --csharp_opt=file_extension=.g.cs
protoc -I="." --csharp_out="Compiled/Data/" Data/*.proto --csharp_opt=file_extension=.g.cs