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

	[Guid("D6A03519-1227-403D-A720-F8D874114E67")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsStreamSummaries
	{
		[DispId(1)]
		PIStreamSummaries[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIStreamSummaries GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIStreamSummaries values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("2D195513-0245-4F98-A533-249D82ECAE7C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsStreamSummaries))]
	[ProgId("PIWebAPIWrapper.PIItemsStreamSummaries")]
	[DataContract]

	public class PIItemsStreamSummaries : IPIItemsStreamSummaries
	{
		public PIItemsStreamSummaries()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIStreamSummaries[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIStreamSummaries GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIStreamSummaries values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIStreamSummaries[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
