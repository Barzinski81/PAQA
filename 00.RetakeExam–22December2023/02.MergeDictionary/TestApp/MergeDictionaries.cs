using System.Collections.Generic;

namespace TestApp;

public class MergeDictionaries
{
    public static Dictionary<string, int> Merge(
        Dictionary<string, int> dict1,
        Dictionary<string, int> dict2)
    {
        Dictionary<string, int> mergedDict = new(dict1);
        
        foreach (KeyValuePair<string, int> kvp in dict2)
        {
            mergedDict[kvp.Key] = kvp.Value;
        }

        return mergedDict;
    }
}
