### Time Intervals

* Second
* Minute
* Hour
* Week
	* Last 7 days
	* Specify first day of week (track usage against data caps)
* Month
	* Last 30 days
	* From specified date (track usage against data caps)
* Year
* All Time

### How Things Should Work

1. Check for data changes on a regular short time interval (1s?) to update GUI and have data incase of crash or something
2. Every minute store the overall data in at that point
3. Work out data transfer over a time period by doing (Data at end) - (Data at start)
