// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
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

	[Guid("B2F5A5AB-CC7B-47C8-85DE-76024D4A3881")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsCacheInstance
	{
		[DispId(1)]
		PICacheInstance[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PICacheInstance GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PICacheInstance values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("63453F55-0E30-4F78-8155-A1692BAE02D4")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsCacheInstance))]
	[ProgId("PIWebAPIWrapper.PIItemsCacheInstance")]
	[DataContract]

	public class PIItemsCacheInstance : IPIItemsCacheInstance
	{
		public PIItemsCacheInstance()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PICacheInstance[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PICacheInstance GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PICacheInstance values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PICacheInstance[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
