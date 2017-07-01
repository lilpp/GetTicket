function isAfter(startDate, endDate) {
    if (startDate > endDate) {
        $("#not-valid_startdate").text = "A kezdés dátuma nem lehet később a befejezésénél."
        $("#not-valid_enddate").text = "A befejezés dátuma nem lehet előbb a kezdésnél."
    }
}