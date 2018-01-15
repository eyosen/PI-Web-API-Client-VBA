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

	[Guid("E3E9ED05-8CFB-47AB-BE97-A25CEC8EF87C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsSecurityMapping
	{
		[DispId(1)]
		PISecurityMapping[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PISecurityMapping GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PISecurityMapping values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("EE3B480F-56FD-4F33-8FE6-D5930C5FD722")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsSecurityMapping))]
	[ProgId("PIWebAPIWrapper.PIItemsSecurityMapping")]
	[DataContract]

	public class PIItemsSecurityMapping : IPIItemsSecurityMapping
	{
		public PIItemsSecurityMapping()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PISecurityMapping[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PISecurityMapping GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PISecurityMapping values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PISecurityMapping[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
