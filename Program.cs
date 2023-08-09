// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

string jsonFileText;
string updatesFileText;
JObject insertionJObj;
JObject oasFileObjects;

// Open insertions file and read into string.
using(StreamReader sw = new("/Users/wayne.myer/gitlab/UpdateOpenApi/UpdateOpenApiSpec/Insertions.json"))
{
    updatesFileText = sw.ReadToEnd();

    // Convert JSON string to JObbject.
    insertionJObj = JObject.Parse(updatesFileText);
    sw.Close();
}

// Parse OpenAPI file that needs additional objects.
using(StreamReader sw = new("/Users/wayne.myer/gitlab/harvey/openapi.json"))
{
    // Convert OAS into JObject.
    jsonFileText = sw.ReadToEnd();
    oasFileObjects = JObject.Parse(jsonFileText);
       
    // Merge new objects into OAS. Things will automagically go where there are supposed to go, 
    // as long as the paths are the same.    
    oasFileObjects?.Merge(insertionJObj, new JsonMergeSettings
    {
        MergeArrayHandling = MergeArrayHandling.Union
    });

    // Write out and close out
    using StreamWriter sw2 = new("testJson");
    string updatedJson = JsonConvert.SerializeObject(oasFileObjects, Formatting.Indented);
    sw2.Write(updatedJson);
    sw2.Flush();
    sw2.Close();
}