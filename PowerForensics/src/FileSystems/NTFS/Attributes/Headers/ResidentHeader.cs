﻿using System;

namespace PowerForensics.Ntfs
{
    #region ResidentHeaderClass

    class ResidentHeader
    {
        #region Properties

        internal CommonHeader commonHeader;
        internal uint AttrSize;
        internal ushort AttrOffset;
        internal byte IndexedFlag;

        #endregion Properties

        #region Constructors

        internal ResidentHeader(byte[] bytes, CommonHeader common)
        {
            commonHeader = common;
            AttrSize = BitConverter.ToUInt32(bytes, 0);
            AttrOffset = BitConverter.ToUInt16(bytes, 4);
            IndexedFlag = bytes[6];
        }

        internal ResidentHeader(byte[] bytes, CommonHeader common, int offset)
        {
            commonHeader = common;
            AttrSize = BitConverter.ToUInt32(bytes, 0x00 + offset);
            AttrOffset = BitConverter.ToUInt16(bytes, 0x04 + offset);
            IndexedFlag = bytes[0x06 + offset];
        }

        #endregion Constructors
    }

    #endregion ResidentHeaderClass
}
