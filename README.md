# DNShift

A free, portable DNS changer for Windows.

DNShift switches the DNS servers on a network adapter without digging through Windows settings. It handles IPv4 and IPv6, comes with presets for the common public resolvers, and puts things back to automatic when you are done.

No installer, no telemetry, no bundled extras. One executable, around 20 KB.

---

## Features

- Change IPv4 and IPv6 DNS servers on any network adapter
- See the DNS currently in use, read straight from the adapter
- Presets for Cloudflare, Google, Quad9, OpenDNS, AdGuard, and Cloudflare's malware-blocking resolver
- Enter your own addresses for anything not in the list
- Restore an adapter to automatic (DHCP) in one click
- Flush the Windows DNS cache
- Runs from a single file, nothing to install

## Requirements

- Windows 7 SP1 or later (tested on Windows 10 and 11)
- .NET Framework 4.8 — already included in Windows 10 and 11
- Administrator rights, since changing network settings requires them

## Download

Grab the latest build from the [Releases](https://github.com/minanatech/DNShift/releases) page, or from [minanatech.com](https://minanatech.com).

Each release lists a SHA-256 checksum. To verify your download:
