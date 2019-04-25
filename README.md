# Agenty.scripting
A replication of [Agenty scripting](https://www.agenty.com/docs/scripting) library in `C#` to test and debug pre-processing and post-processing scripts locally


```
Install-Package Agenty.scripting
```

## Post-processing
```
// Set your api key
Agenty.ApiKey = "AGENTY_API_KEY";

// Get agent result as DataTable
var table = Agenty.Cloud.GetAgentResult("<AGENT_ID>");
            
// Write your code here to test

// Print the table for preview locally
table.Dump();

// Set the result back to agent
//table.SetAgentResult();
```
## Replace example
```
// Set your api key
Agenty.ApiKey = "AGENTY_API_KEY";

// Get agent result as DataTable
var table = Agenty.Cloud.GetAgentResult("<AGENT_ID>");
            
// Write your code here to test
foreach(DataRow row in table.Rows)
{
	row["Field1"] = row["Field1"].ToString().Replace("abc", "xyz");
}

// Print the table for preview locally
table.Dump();

// Set the result back to agent
//table.SetAgentResult();
```
