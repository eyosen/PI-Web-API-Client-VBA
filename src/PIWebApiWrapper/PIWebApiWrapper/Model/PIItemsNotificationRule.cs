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

	[Guid("C54EDDB9-BC73-4CE2-BB1A-A5C04348AB43")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsNotificationRule
	{
		[DispId(1)]
		PINotificationRule[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PINotificationRule GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PINotificationRule values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		PIPaginationLinks Links { get; set; }

	}

	[Guid("0E10C5B4-52D5-4466-A981-4B7DC48F0539")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsNotificationRule))]
	[ProgId("PIWebAPIWrapper.PIItemsNotificationRule")]
	[DataContract]

	public class PIItemsNotificationRule : IPIItemsNotificationRule
	{
		public PIItemsNotificationRule()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PINotificationRule[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PINotificationRule GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PINotificationRule values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PINotificationRule[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPaginationLinks Links { get; set; }

	}
}
