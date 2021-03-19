#!/bin/sh

# Send stdin to wslclip.exe as arg
read clip
powershell.exe wslclip.exe $clip
