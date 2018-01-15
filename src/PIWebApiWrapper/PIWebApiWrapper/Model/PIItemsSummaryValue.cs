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

	[Guid("E575345D-DBFA-4247-AA54-4BBFE6DC394D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsSummaryValue
	{
		[DispId(1)]
		PISummaryValue[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PISummaryValue GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PISummaryValue values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("01B115D2-A337-412E-B4E9-CC2EBD872E8B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsSummaryValue))]
	[ProgId("PIWebAPIWrapper.PIItemsSummaryValue")]
	[DataContract]

	public class PIItemsSummaryValue : IPIItemsSummaryValue
	{
		public PIItemsSummaryValue()
		{
		}

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
