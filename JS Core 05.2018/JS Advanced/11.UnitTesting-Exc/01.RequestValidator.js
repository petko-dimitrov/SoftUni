function validateRequest(obj) {
    const METHODS = ['GET', 'POST', 'DELETE', 'CONNECT'];
    const VERSIONS = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];
    let uriRegex = /\*|^[A-Za-z0-9.]+$/;
    let messageRegex = /^[^<>\\&'"]*$/;
   
    if (!METHODS.includes(obj.method)) {
        throw new Error("Invalid request header: Invalid Method");
    }
    
    if (!uriRegex.test(obj.uri) || obj.uri === undefined) {
        throw new Error("Invalid request header: Invalid URI")
    }
    
    if (!VERSIONS.includes(obj.version)) {
        throw new Error("Invalid request header: Invalid Version")
    }
    
    if (!messageRegex.test(obj.message) || obj.message === undefined) {
        throw new Error("Invalid request header: Invalid Message")
    }

    return obj;
}

validateRequest({
    method: 'GET'
});