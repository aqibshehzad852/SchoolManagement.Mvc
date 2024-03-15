

 // Save theme preference
 document.getElementById('toggle-theme').addEventListener('change', function () {
    localStorage.setItem('theme', this.checked ? 'dark' : 'light');
    applyTheme(); // Apply your theme styles
});

// Apply theme on page load
document.addEventListener('DOMContentLoaded', function () {
    const savedTheme = localStorage.getItem('theme');
    if (savedTheme === 'dark') {
        document.getElementById('toggle-theme').checked = true;
        applyTheme(); // Apply your theme styles
    }
});



function applyTheme() {
    const isDarkTheme = document.getElementById('toggle-theme').checked;
    
    document.body.style.backgroundColor = isDarkTheme ? '#212529' : 'white';
    
    const textColor = isDarkTheme ? 'white' : 'black';
    document.body.style.color = textColor;


}


