﻿/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.1
 * Since       2015-07-20
 * Filename    XContactType.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Deserializers;

namespace RicOneApi.Models.XPress
{
    /// <summary>
    /// XContactType
    /// </summary>
    public class XContactType
    {
        public XContactType()
        {
            refId = null;
            name = new XPersonNameType();
            otherNames = new XOtherPersonNameListType();
            localId = null;
            otherIds = new XOtherPersonIdListType();
            appProvisioningInfo = new XAppProvisioningInfoType();
            address = new XPersonAddressType();
            phoneNumber = new XTelephoneType();
            otherPhoneNumbers = new XTelephoneListType();
            email = new XEmailType();
            otherEmails = new XEmailListType();
            sex = null;
            employerType = null;
            relationships = new XContactStudentRelationshipListType();
        }
        [DeserializeAs(Name = "@refId")]
        public string refId { get; set; }
        public XPersonNameType name { get; set; }
        public XOtherPersonNameListType otherNames { get; set; }
        public string localId { get; set; }
        public XOtherPersonIdListType otherIds { get; set; }
        public XAppProvisioningInfoType appProvisioningInfo { get; set; }
        public XPersonAddressType address { get; set; }
        public XTelephoneType phoneNumber { get; set; }
        public XTelephoneListType otherPhoneNumbers { get; set; }
        public XEmailType email { get; set; }
        public XEmailListType otherEmails { get; set; }
        public string sex { get; set; }
        public string employerType { get; set; }
        public XContactStudentRelationshipListType relationships { get; set; }
    }
}
