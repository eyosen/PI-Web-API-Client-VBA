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

	[Guid("732E59C1-A9FE-4A8C-964D-9ABBEA41A290")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsNotificationRuleSubscriber
	{
		[DispId(1)]
		PINotificationRuleSubscriber[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PINotificationRuleSubscriber GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PINotificationRuleSubscriber values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		PIPaginationLinks Links { get; set; }

	}

	[Guid("FF24ED05-9871-4981-AFA5-4F5F95916E46")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsNotificationRuleSubscriber))]
	[ProgId("PIWebAPIWrapper.PIItemsNotificationRuleSubscriber")]
	[DataContract]

	public class PIItemsNotificationRuleSubscriber : IPIItemsNotificationRuleSubscriber
	{
		public PIItemsNotificationRuleSubscriber()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PINotificationRuleSubscriber[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PINotificationRuleSubscriber GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PINotificationRuleSubscriber values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PINotificationRuleSubscriber[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPaginationLinks Links { get; set; }

	}
}
