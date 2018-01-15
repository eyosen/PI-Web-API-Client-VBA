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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Model
{

	[Guid("29ED89BE-5EB1-44D4-8E7B-1F68D8D1F47C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsEnumerationSet
	{
		[DispId(1)]
		PIEnumerationSet[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIEnumerationSet GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIEnumerationSet values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("D22DFD36-45E5-481D-85B6-17035E7B4B1C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsEnumerationSet))]
	[ProgId("PIWebAPIWrapper.PIItemsEnumerationSet")]
	[DataContract]

	public class PIItemsEnumerationSet : IPIItemsEnumerationSet
	{
		public PIItemsEnumerationSet()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIEnumerationSet[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIEnumerationSet GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIEnumerationSet values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIEnumerationSet[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
