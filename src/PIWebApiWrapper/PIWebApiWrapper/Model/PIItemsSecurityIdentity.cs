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

	[Guid("89615D92-8B89-4195-A10B-51F8D97C653D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsSecurityIdentity
	{
		[DispId(1)]
		PISecurityIdentity[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PISecurityIdentity GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PISecurityIdentity values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("C3819F0C-6B26-4F73-A19B-4B1CEAD87513")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsSecurityIdentity))]
	[ProgId("PIWebAPIWrapper.PIItemsSecurityIdentity")]
	[DataContract]

	public class PIItemsSecurityIdentity : IPIItemsSecurityIdentity
	{
		public PIItemsSecurityIdentity()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PISecurityIdentity[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PISecurityIdentity GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PISecurityIdentity values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PISecurityIdentity[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
