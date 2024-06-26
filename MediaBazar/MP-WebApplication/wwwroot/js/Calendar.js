/*GETTING HIDDEN ELEMENTS*/
const startTimeHidden = document.getElementById('start-time');
const endTimeHidden = document.getElementById('end-time');
const eventTypeHidden = document.getElementById('event-type');

/*GETTING EVENT TYPE BUTTONS*/
const availabilityBtn = document.getElementById('availability');
const leaveBtn = document.getElementById('leave');
    /* Getting leave description*/
    const leaveDescription = document.getElementById('leave_description');
    const leaveText = document.getElementById('leave_text');
    //Getting the row box of the leave description
    const leaveDescriptionBox = document.getElementById('leave_description_box');

//Function to reset all buttons as unselected
function UnselectAllButtons() {
    availabilityBtn.classList.remove('active');
    leaveBtn.classList.remove('active');
    leaveDescription.classList.add('hidden');
    leaveDescription.required = false;
    leaveText.classList.add('hidden');
    leaveDescriptionBox.classList.add('hidden');
}

//Event listeners for the two buttons setting them active
availabilityBtn.addEventListener("click", () => {
    UnselectAllButtons();
    availabilityBtn.classList.add('active');
    eventTypeHidden.value = "Availability";
})
leaveBtn.addEventListener("click", () => {
    UnselectAllButtons();
    leaveBtn.classList.add('active');
    eventTypeHidden.value = "Leave";
    leaveDescription.required = true;
    leaveDescription.classList.remove('hidden');
    leaveText.classList.remove('hidden');
    leaveDescriptionBox.classList.remove('hidden');
})

document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar');
    var calendar = new FullCalendar.Calendar(calendarEl, {
        locale: 'en',
        slotLabelFormat: [
            { hour: 'numeric', minute: '2-digit', hour12: false }
        ],
        slotMinTime: '08:00:00',
        slotMaxTime: '20:00:00',
        slotDuration: '04:00:00',
        height: 570,
        nowIndicator: true,
        selectable: true,
        selectConstraint: {
            startTime: Date.now,
            endTime: '2040-12-05T22:00:00' },
        unselectAuto: false,
        headerToolbar: { center: 'dayGridMonth,timeGridWeek' },
        initialView: 'timeGridWeek',
        firstDay: 1,
        allDaySlot: false,
        events: events,
        select: function (info) {
            startTimeHidden.value = formatDateToString(info.start);
            endTimeHidden.value = formatDateToString(info.end);
        },
    });

    calendar.render();
});

function formatDateToString(date) {
    const year = date.getFullYear();
    const month = String(date.getMonth() + 1).padStart(2, '0');
    const day = String(date.getDate()).padStart(2, '0');
    const hours = String(date.getHours()).padStart(2, '0');
    const minutes = String(date.getMinutes()).padStart(2, '0');

    return `${year}-${month}-${day}T${hours}:${minutes}`;
}