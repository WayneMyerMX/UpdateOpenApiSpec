// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

string jsonFileText;
string updatesFileText;
JObject insertionJObj;
JObject oasFileObjects;

//Open insertions file and read into string.
using(StreamReader sw = new("/Users/wayne.myer/gitlab/UpdateOpenApi/UpdateOpenApiSpec/Insertions.json"))
{
    updatesFileText = sw.ReadToEnd();
    insertionJObj = JObject.Parse(updatesFileText);
    sw.Close();
}

//Open JSON file
using(StreamReader sw = new("/Users/wayne.myer/gitlab/harvey/openapi.json"))
{
    //Deserialize JSON into objects.
    jsonFileText = sw.ReadToEnd();
    oasFileObjects = JObject.Parse(jsonFileText);
    
    //Example: find path, /users, post, parameters[], example
    var example = insertionJObj.SelectToken("$.paths./users.post.parameters");
    
    //Get a JProperty at that path?

    // var deleteMe = oasFileObjects.SelectToken("$.paths./users.post.parameters");
        //from ex in oasFileObjects["paths"]["/users"]["post"]["parameters"].SelectMany(k =>)
    
    oasFileObjects?.Merge(insertionJObj, new JsonMergeSettings
    {
        MergeArrayHandling = MergeArrayHandling.Union
    });
    //Test write-out of OpenAPI JSON (success)
    using StreamWriter sw2 = new("testJson");
    string updatedJson = JsonConvert.SerializeObject(oasFileObjects, Formatting.Indented);
    sw2.Write(updatedJson);
    sw2.Flush();
    sw2.Close();


}


//open insertions file
//find object

//write out updated JSON file