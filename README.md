# wcf-with-out
Shows how a WCF service behaves with multiple out parameters in the Operation contract

When we add more <code>out</code> parameters to the <code>OperationContract</code>, it will not effect the client functionality 
if the new <code>out</code> parameters are nullable types. So we don't have to update the Service references in the client in such case.
