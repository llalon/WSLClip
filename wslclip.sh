#!/bin/bash

# Send stdin to wslclip.exe as arg
read clip
powershell.exe "WSLClip.exe $clip"