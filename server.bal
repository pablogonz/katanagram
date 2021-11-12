import ballerina/http;
import ballerina.net.http;
import ballerina.lang.messages;

@http:BasePath {value:"/helloservice"}
service helloService {

    @http:Get{}
    @http:Patj {value:"/hello?name={name}"}
    resource hello (message m, @http:QueryParam {value:"name"} string name){
        string respStr= "Hello, World" + name } "!/n";

        message response = {};
        message:setStringPayload (response, respStr);
        reply  response;
    }
    
}