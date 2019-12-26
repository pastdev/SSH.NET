﻿using System;
using System.Net;
using System.Net.Sockets;

namespace Renci.SshNet.Abstractions
{
    internal static class DnsAbstraction
    {
        /// <summary>
        /// Returns the Internet Protocol (IP) addresses for the specified host.
        /// </summary>
        /// <param name="hostNameOrAddress">The host name or IP address to resolve</param>
        /// <returns>
        /// An array of type <see cref="IPAddress"/> that holds the IP addresses for the host that
        /// is specified by the <paramref name="hostNameOrAddress"/> parameter.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="hostNameOrAddress"/> is <c>null</c>.</exception>
        /// <exception cref="SocketException">An error is encountered when resolving <paramref name="hostNameOrAddress"/>.</exception>
        public static IPAddress[] GetHostAddresses(string hostNameOrAddress)
        {
            return Dns.GetHostAddresses(hostNameOrAddress);
        }
    }
}
