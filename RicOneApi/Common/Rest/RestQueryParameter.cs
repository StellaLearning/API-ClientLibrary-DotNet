﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicOneApi.Common.Rest
{
    class RestQueryParameter
    {
        private string opaqueMarker;
        private AUPPEnum aupp;

        public RestQueryParameter()
        {
        }

        public RestQueryParameter(string opaqueMarker)
        {
            this.opaqueMarker = opaqueMarker;
        }

        public string OpaqueMarker { get => opaqueMarker; set => opaqueMarker = value; }
        internal AUPPEnum Aupp { get => aupp; set => aupp = value; }

        public bool HasOpaqueMarker() => !string.IsNullOrEmpty(opaqueMarker);

        public bool IsCreateUsers()
        {
            if(aupp != null)
            {
              return aupp.Equals(AUPPEnum.CREATE);
            }
            return false;
        }

        public bool IsDeleteUsers()
        {
            if (aupp != null)
            {
                return aupp.Equals(AUPPEnum.DELETE);
            }
            return false;
        }

        public bool IsGetUsers()
        {
            if (aupp != null)
            {
                return aupp.Equals(AUPPEnum.GET);
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
