// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Collections.Generic;


namespace PIWebAPIWrapper.Client
{
    public class CustomDictionaryForQueryString
    {
        private List<KeyValuePair<String, String>> items = new List<KeyValuePair<String, String>>();
        public void Add(string key, object value, bool isMulti)
        {
            if ((value != null) && (value.ToString() != ""))
            {
                if (isMulti == true)
                {
                    string[] valueList = Convert.ToString(value).Split(',');
                    foreach (var val in valueList)
                    {
                        items.Add(new KeyValuePair<string, string>(key, val.Trim()));
                    }
                }
                else
                {
                    items.Add(new KeyValuePair<string, string>(key, value.ToString()));
                }
            }
        }

        public int Count
        {
            get
            {
                return items.Count;
            }
        }


        public MyEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        public class MyEnumerator
        {
            int nIndex;
            CustomDictionaryForQueryString collection;
            public MyEnumerator(CustomDictionaryForQueryString coll)
            {
                collection = coll;
                nIndex = -1;
            }

            public bool MoveNext()
            {
                nIndex++;
                return (nIndex < collection.items.Count);
            }

            public KeyValuePair<String, String> Current
            {
                get
                {
                    return (collection.items[nIndex]);
                }
            }
        }
    }
}
