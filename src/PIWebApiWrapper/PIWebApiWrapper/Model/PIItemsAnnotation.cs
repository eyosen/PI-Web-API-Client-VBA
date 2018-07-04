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

	[Guid("1A15E27C-0BC7-4505-A770-DCED5DD0385C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAnnotation
	{
		[DispId(1)]
		PIAnnotation[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAnnotation GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAnnotation values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		PIPaginationLinks Links { get; set; }

	}

	[Guid("DAA676E8-8BDC-4EFD-9FB8-51D33F497F05")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAnnotation))]
	[ProgId("PIWebAPIWrapper.PIItemsAnnotation")]
	[DataContract]

	public class PIItemsAnnotation : IPIItemsAnnotation
	{
		public PIItemsAnnotation()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAnnotation[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAnnotation GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAnnotation values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAnnotation[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPaginationLinks Links { get; set; }

	}
}
