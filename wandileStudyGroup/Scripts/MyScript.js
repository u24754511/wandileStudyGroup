document.addEventListener("DOMContentLoaded", function () {
    // Select all delete buttons
    const deleteButtons = document.querySelectorAll('.deleteBtn');//deleteBtn is the class

    // Loop through each button and add the event listener
    deleteButtons.forEach(button => {
        button.addEventListener('click', function () {
            // Find the row in the table that the button is in
            const row = button.parentNode.parentNode;

            // Remove everthing from the row in the table
            row.parentNode.removeChild(row);
        });
    });
});

document.addEventListener("DOMContentLoaded", function () {
    // Select all the rows in the table 
    const rows = document.querySelectorAll('table tr');

    // Loop through each row (starting from index to skip header)
    rows.forEach(function (row, index) {
        
        if (index === 0) return;

        // Get the first name from the current row 
        const firstName = row.cells[1].textContent.trim();

        // Check if the first name starts with "S" 
        if (firstName.charAt(0).toUpperCase() === "S") {
            // Change the color of the text in this row to red
            row.style.color = "red";
        }
    });
});

document.addEventListener("DOMContentLoaded", function () {
    // Get the current page name from the URL
    const currentPage = window.location.pathname.split("/").pop();  // Extracts the file name like Wandile.html

    // Select all the links in the navigation
    const navLinks = document.querySelectorAll('.everything a');

    // Loop through each link and add the 'active' class if the href matches the current page
    navLinks.forEach(function (link) {
        if (link.getAttribute('href') === currentPage) {
            link.classList.add('active');
        }
    });
});
