// Wait until the whole page (HTML) has finished loading
document.addEventListener("DOMContentLoaded", () => {
    const button = document.getElementById("getTimeBtn");
    const timeFrame = document.getElementById("timeFrame");
    let clockInterval = null;

    if (button) {
        button.addEventListener("click", () => {

            // Show the frame if hidden
            timeFrame.style.display = "block";

            // Stop previous interval
            if (clockInterval) clearInterval(clockInterval);

            // Function to update the time every second
            function updateLocalTime() {
                const now = new Date(); // user's local time
                const hours = now.getHours().toString().padStart(2, '0');
                const minutes = now.getMinutes().toString().padStart(2, '0');
                const seconds = now.getSeconds().toString().padStart(2, '0');

                // Optional: AM/PM format
                const ampm = now.getHours() >= 12 ? 'PM' : 'AM';
                const hours12 = now.getHours() % 12 || 12;

                timeFrame.innerText = `${hours12.toString().padStart(2, '0')}:${minutes}:${seconds} ${ampm}`;

                // Pop animation (optional)
                timeFrame.animate([
                    { transform: 'scale(0.95)', opacity: 0.8 },
                    { transform: 'scale(1.05)', opacity: 1 },
                    { transform: 'scale(1)', opacity: 1 }
                ], {
                    duration: 300,
                    easing: 'ease-out'
                });
            }

            // Update immediately
            updateLocalTime();

            // Then every second
            clockInterval = setInterval(updateLocalTime, 1000);
        });
    }
});