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

	[Guid("86FBC876-E176-4D43-97E3-6E355B9909AE")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsNotificationRuleTemplate
	{
		[DispId(1)]
		PINotificationRuleTemplate[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PINotificationRuleTemplate GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PINotificationRuleTemplate values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		PIPaginationLinks Links { get; set; }

	}

	[Guid("ADBE97E3-485E-4DC5-97DF-CE720DFD5D96")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsNotificationRuleTemplate))]
	[ProgId("PIWebAPIWrapper.PIItemsNotificationRuleTemplate")]
	[DataContract]

	public class PIItemsNotificationRuleTemplate : IPIItemsNotificationRuleTemplate
	{
		public PIItemsNotificationRuleTemplate()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PINotificationRuleTemplate[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PINotificationRuleTemplate GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PINotificationRuleTemplate values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PINotificationRuleTemplate[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPaginationLinks Links { get; set; }

	}
}
