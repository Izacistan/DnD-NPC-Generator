//this is javascript to validate and autofill the form to Edit or Generate an NPC form

function getBonusFromLevel(level) {
    if (Number(level) == 0) {
        return "0";
    } else {
        return Math.floor(2 + (level - 1) / 4).toString();
    }
}
function getBonusFromStat(stat) {
    let minus10 = stat - 10;
    return Math.floor(minus10 / 2);
}

$(document).ready(function () {
    var $levelInput = $('input[name="Level"]');
    var $proBonusInput = $('input[name="proBonus"]');
    var $baseStats = $('#form-stats table tbody :first-child');

    //when changing level update proficiency bonus
    $levelInput.blur(function () {
        let val = $levelInput.val();
        $proBonusInput.val(getBonusFromLevel(val));
        $proBonusInput.attr("value", getBonusFromLevel(val));
        console.log($proBonusInput.val());
    });

    //when changing base stats calculate modifiers
    $baseStats.children().each(function () {
        let posIndex = $(this).index();
        $(this).children().blur(function () {
            let val = $(this).val();
            $(this).closest('tr').next('tr').children().eq(posIndex).children(':first').val(getBonusFromStat(val));
        });
    });
});