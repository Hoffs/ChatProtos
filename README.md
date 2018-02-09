# Proto explanation

Data folder holds basic types of objects that are sent/received and used in general.

Networking folder holds all information about messages sent from/to the client/server.
- Messages: types of messages that can be sent/received.
--	Every message proto should have Request+Response messages
- RequestType: What kind of request is being sent/received.
- ResponseStatus: Returns the status of sent request.
- Request: the base request message which contain the Type and one of the `Messages` but as bytes. Client/Server makes the appropriate message from the bytes sent/received.

# Usage

- First get protoc binary from Google Protobuf
- Place it in root directory
- Call build.bat
- Generated files should be in `Compiled/` directory