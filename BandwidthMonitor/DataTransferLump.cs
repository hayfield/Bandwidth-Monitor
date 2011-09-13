using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandwidthMonitor
{
    /// <summary>
    /// A lump of data that has been transfered in and out
    /// </summary>
    class DataTransferLump
    {
        /// <summary>
        /// The number of bytes that have gone in
        /// </summary>
        public long bytesIn;
        /// <summary>
        /// The number of bytes that have gone out
        /// </summary>
        public long bytesOut;

        public DataTransferLump(long newBytesIn, long newBytesOut)
        {
            bytesIn = newBytesIn;
            bytesOut = newBytesOut;
        }

        /// <summary>
        /// Sets the number of bytes in and out as the specified values
        /// </summary>
        /// <param name="newBytesIn"></param>
        /// <param name="newBytesOut"></param>
        public void set(long newBytesIn, long newBytesOut)
        {
            bytesIn = newBytesIn;
            bytesOut = newBytesOut;
        }
    }
}
