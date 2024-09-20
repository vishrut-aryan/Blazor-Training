function setHtmlClass(isDarkMode) {
    document.documentElement.setAttribute('data-bs-theme', isDarkMode ? 'dark' : 'light');
}