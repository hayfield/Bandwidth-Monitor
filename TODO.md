## Logging

* Add a temp-logging function so data isn't lost when the program is closed part way through a minute
* Add ability to disable logging on certain adapters

## Log View

* Sort out timezones with the dates (all UTC at the moment)
* Find a way to correctly sort the Data In and Out without adding extra columns containing doubles. Possibly see [DataGridView](http://msdn.microsoft.com/en-us/library/system.windows.forms.datagridview.aspx), [DataGridView.Sort](http://msdn.microsoft.com/en-us/library/wstxtkxs.aspx), [DataGridViewColumn.SortMode](http://msdn.microsoft.com/en-us/library/system.windows.forms.datagridviewcolumn.sortmode.aspx)

## Data

* Try and fix whatever is causing the data to be funny such that it restarts and writes something to the restart-log.txt

## Installer

* Create an installer
