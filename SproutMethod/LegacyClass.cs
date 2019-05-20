using System;
using System.Collections.Generic;

namespace SproutMethod
{
    public class LegacyClass
    {
        public void AppendDictionary<TKey,TValue>(Dictionary<TKey,TValue> fromDict, Dictionary<TKey,TValue> toDict)
        {
            Dictionary<TKey,TValue> validItems = GetValidItems(fromDict, toDict);

            foreach (var item in validItems)
            {
                    toDict.Add(item.Key, item.Value);
            }
        }

        public Dictionary<TKey, TValue> GetValidItems<TKey, TValue>(Dictionary<TKey, TValue> fromDict, Dictionary<TKey,
            TValue> toDict)
        {
            var result = new Dictionary<TKey, TValue>();

            foreach (var item in fromDict)
            {
                if (!toDict.ContainsKey(item.Key))
                    result.Add(item.Key,item.Value);
            }
            return result;
        }
    }
}
