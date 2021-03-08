# WSLClip
A small rust utility to pipe outputs to the windows clipboard from WSL.

## Usage

##### From Linux (WSL):

Add the output of command to the windows clipboard. 
```{bash}
cat file.txt | wslclip.sh
```
Ensure wslclip.sh is included in user path.

## Installation

##### From Windows:

Ensure rust is installed and added to the windows path.
```{bash}
cargo install --path wslclip
```