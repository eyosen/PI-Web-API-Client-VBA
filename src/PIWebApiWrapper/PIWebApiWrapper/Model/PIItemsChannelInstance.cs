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

	[Guid("A77AB981-5165-4BBB-A26C-8C4A9FFE684E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsChannelInstance
	{
		[DispId(1)]
		PIChannelInstance[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIChannelInstance GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIChannelInstance values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		PIPaginationLinks Links { get; set; }

	}

	[Guid("D2179937-9E34-4880-B8E6-C8D8BF4DEBD3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsChannelInstance))]
	[ProgId("PIWebAPIWrapper.PIItemsChannelInstance")]
	[DataContract]

	public class PIItemsChannelInstance : IPIItemsChannelInstance
	{
		public PIItemsChannelInstance()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIChannelInstance[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIChannelInstance GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIChannelInstance values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIChannelInstance[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPaginationLinks Links { get; set; }

	}
}
