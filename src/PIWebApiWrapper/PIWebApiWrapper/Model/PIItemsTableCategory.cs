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

	[Guid("CA034EE6-DB6C-4FDE-A53B-10C5B797116D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsTableCategory
	{
		[DispId(1)]
		PITableCategory[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PITableCategory GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PITableCategory values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("BC6CBBFA-024B-4E9D-875F-0A5002B6D550")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsTableCategory))]
	[ProgId("PIWebAPIWrapper.PIItemsTableCategory")]
	[DataContract]

	public class PIItemsTableCategory : IPIItemsTableCategory
	{
		public PIItemsTableCategory()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PITableCategory[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PITableCategory GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PITableCategory values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PITableCategory[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
