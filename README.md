# LocalJournal
-Simple application that adds a timestamp to new entries in a journal, meant for journals or diaries.
-When using this, you will need to edit the program.cs file; create your own .txt file then list the full filepath inside the quotes, save it, run it. 

-This program has one annoyance, which is that when entering information it can only accept less than 255 characters, because that is the maximum size a string can hold. So the solution around it is to simply cut off a word when you run out of space press enter then continue entering.
-The timestamp is only entered when the program is opened. So you click on the executable, type in, the timestamp gets saved at the beginning of the initial string that is saved. Every string after that you type does not get a timestamp. However, when you close the program, then reopen it, it will again add a timestamp at the beginning of the first string saved.
-Incredibly useful to keep a running diary or journal over a long span of time.
