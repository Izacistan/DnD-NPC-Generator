$(document).ready(function () {
    //event handlers
    $("#filter-name").on("keyup", filterSpells);
    $("#filter-class").change(filterSpells);
    $("#filter-level").change(filterSpells);
    $("#filter-school").change(filterSpells);
});

function filterSpells() {
    console.log("filtering");
    //name
    var searchName = $("#filter-name").val().toLowerCase();
    var searchClass = $("#filter-class").val().toLowerCase();
    var searchLevel = $("#filter-level").val().toLowerCase();
    var searchSchool = $("#filter-school").val().toLowerCase();

    //filter
    $("#spell-list .spell-panel").filter(function () {
        let hide = false;
        let name = $(this).find(".spell-name").text().toLowerCase();
        let classFind = ".spell-" + searchClass;
        let level = $(this).find(".spell-level").text().toLowerCase();
        let school = $(this).find(".spell-school").text().toLowerCase();

        //checks
        if (searchName != "") {
            if (name.indexOf(searchName) < 0) {
                hide = true;
            }
        }
        if (searchClass != "all") {
            if ($(this).find(classFind).length > 0) {
                hide = false;
            } else {
                hide = true;
            }
        }
        if (searchLevel != "all") {
            if (level != searchLevel) {
                hide = true;
            }
        }
        if (searchSchool != "all") {
            if (school != searchSchool) {
                keep = true;
            }
        }
        //finally toggle all based on hide
        $(this).toggle(!hide);
    });
}