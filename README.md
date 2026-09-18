# DNShift

A free, portable DNS changer for Windows.

DNShift switches the DNS servers on a network adapter without digging through Windows settings. It handles IPv4 and IPv6, comes with presets for the common public resolvers, and puts things back to automatic when you are done.

No installer, no telemetry, no bundled extras. One executable, under 60 KB.

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
- .NET Framework 4.8 - already included in Windows 10 and 11
- Administrator rights, since changing network settings requires them

## Download

Grab the latest build from the [Releases](https://github.com/minanatech/DNShift/releases) page, or from [minanatech.com](https://minanatech.com).

Each release lists a SHA-256 checksum. To verify your download, run this in Command Prompt:

```
certutil -hashfile DNShift.exe SHA256
```

The result should match the checksum published with that release.

## A note on antivirus warnings

Windows SmartScreen or your antivirus may warn about DNShift. This is what happens to any new executable from a developer without an established download history - it is a reputation check, not a detection of anything in the file.

You do not have to take our word for it. The source is here, the checksum is published, and the program is small enough to read in one sitting. Build it yourself if you would rather not run our binary.

## Building from source

Open `DNShift.csproj` in Visual Studio and build in Release configuration. The project targets .NET Framework 4.8 and has no external dependencies.

## Why

Changing DNS on Windows means opening Settings, finding the adapter, opening its properties, locating the right protocol, and typing the addresses in - then repeating all of it to undo the change. This does the same thing in two clicks and can undo it in one.

## Contributing

Bug reports and suggestions are welcome through [Issues](https://github.com/minanatech/DNShift/issues). Pull requests are fine too, though for anything substantial it is worth opening an issue first so the work is not wasted.

## Licence

Released under the MIT Licence. See [LICENSE](LICENSE) for the full text.

The application icon is from the [Farm-Fresh Web Icons](https://www.fatcow.com/free-icons) set by FatCow Web Hosting, used under Creative Commons Attribution 3.0.

---

Made by [minanatech.com](https://minanatech.com)
