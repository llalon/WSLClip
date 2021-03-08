use std::env;

use clipboard_win::{formats, get_clipboard, set_clipboard};

fn main() {
    // Parse string
    let args: Vec<String> = env::args().collect();
    let clip = &args[1..args.len()].join(" ");

    set_clipboard(formats::Unicode, clip).expect("To set clipboard");

    // Check success
    let result: String = get_clipboard(formats::Unicode).expect("To set clipboard");
    assert_eq!(result, *clip);
}
