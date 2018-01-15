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

	[Guid("19BE8345-7429-4C45-8455-0A5B714DC4E8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIStreamSummaries
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Name { get; set; }

		[DispId(3)]
		string Path { get; set; }

		[DispId(4)]
		PISummaryValue[] Items { get; set; }

		[DispId(5)]
		int GetItemsLength();

		[DispId(6)]
		PISummaryValue GetItem(int i);

		[DispId(7)]
		void SetItem(int i, PISummaryValue values);

		[DispId(8)]
		void CreateItemsArray(int i);

		[DispId(9)]
		object Links { get; set; }

	}

	[Guid("E9C3A6F2-DCB1-4CFE-8726-6D3A59E0350A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIStreamSummaries))]
	[ProgId("PIWebAPIWrapper.PIStreamSummaries")]
	[DataContract]

	public class PIStreamSummaries : IPIStreamSummaries
	{
		public PIStreamSummaries()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PISummaryValue[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PISummaryValue GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PISummaryValue values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PISummaryValue[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
