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

	[Guid("77EE3B5A-9156-40E7-9885-138DF0BB2B04")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsTimeRulePlugIn
	{
		[DispId(1)]
		PITimeRulePlugIn[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PITimeRulePlugIn GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PITimeRulePlugIn values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("69FD7A96-E689-4897-BD15-BC77B7C7E1F3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsTimeRulePlugIn))]
	[ProgId("PIWebAPIWrapper.PIItemsTimeRulePlugIn")]
	[DataContract]

	public class PIItemsTimeRulePlugIn : IPIItemsTimeRulePlugIn
	{
		public PIItemsTimeRulePlugIn()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PITimeRulePlugIn[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PITimeRulePlugIn GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PITimeRulePlugIn values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PITimeRulePlugIn[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
