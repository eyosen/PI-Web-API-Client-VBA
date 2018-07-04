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

	[Guid("D0DB78C6-DBEC-4629-9FDC-6D8A8E7A6383")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsStreamUpdatesRegister
	{
		[DispId(1)]
		PIStreamUpdatesRegister[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIStreamUpdatesRegister GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIStreamUpdatesRegister values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		PIPaginationLinks Links { get; set; }

	}

	[Guid("595DEB6E-B2A3-4735-A4B3-F71182AE699E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsStreamUpdatesRegister))]
	[ProgId("PIWebAPIWrapper.PIItemsStreamUpdatesRegister")]
	[DataContract]

	public class PIItemsStreamUpdatesRegister : IPIItemsStreamUpdatesRegister
	{
		public PIItemsStreamUpdatesRegister()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIStreamUpdatesRegister[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIStreamUpdatesRegister GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIStreamUpdatesRegister values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIStreamUpdatesRegister[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPaginationLinks Links { get; set; }

	}
}
