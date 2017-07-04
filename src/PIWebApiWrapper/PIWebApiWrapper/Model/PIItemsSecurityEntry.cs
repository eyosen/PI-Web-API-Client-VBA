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

	[Guid("607571A9-E330-4891-AACE-B16EC38D5B52")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsSecurityEntry
	{
		[DispId(1)]
		PISecurityEntry[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PISecurityEntry GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PISecurityEntry values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("77F69282-2E4D-49B8-B6B6-7A1F21F10009")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsSecurityEntry))]
	[ProgId("PIWebAPIWrapper.PIItemsSecurityEntry")]
	[DataContract]

	public class PIItemsSecurityEntry : IPIItemsSecurityEntry
	{
		public PIItemsSecurityEntry()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PISecurityEntry[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PISecurityEntry GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PISecurityEntry values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PISecurityEntry[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
