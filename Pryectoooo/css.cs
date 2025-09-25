/* --- INICIO DEL NUEVO ESTILO ELEGANTE --- */
:root {
    --bg-color: #f8f9fa;
    --surface-color: #ffffff;
    --primary-text: #212529;
    --secondary-text: #6c757d;
    --accent-color: #34568B; /* Un azul más profundo y serio */
    --border-color: #dee2e6;
    --shadow-color: rgba(0, 0, 0, 0.05);
}

/* Importar fuentes de Google */
@import url('https://fonts.googleapis.com/css2?family=Lora:ital,wght@0,400;0,600;1,400&family=Montserrat:wght@700&display=swap');

body {
    font-family: 'Lora', serif;
    line-height: 1.7;
    margin: 0;
    padding: 0;
    background-color: var(--bg-color);
    color: var(--primary-text);
    scroll-behavior: smooth;
    font-size: clamp(1rem, 0.95rem + 0.25vw, 1.15rem); 
}

h1, h2, h3 {
    font-family: 'Montserrat', sans-serif;
    font-weight: 700;
}

header {
    background-color: var(--surface-color);
    padding: 25px 40px;
    border-bottom: 1px solid var(--border-color);
    text-align: center;
    position: sticky;
    top: 0;
    z-index: 1000;
    box-shadow: 0 4px 12px var(--shadow-color);
}

header h1 {
    margin: 0 0 15px 0;
    font-size: clamp(2rem, 1.5rem + 2.5vw, 3rem);
    color: var(--primary-text);
}

#searchInput {
    width: 60%;
    max-width: 450px;
    padding: 12px 20px;
    border: 1px solid var(--border-color);
    border-radius: 30px;
    font-size: 1em;
    font-family: 'Lora', serif;
    transition: all 0.3s ease;
}

#searchInput:focus {
    outline: none;
    border-color: var(--accent-color);
    box-shadow: 0 0 0 3px rgba(52, 86, 139, 0.2);
}

main {
    padding: 30px 40px;
    max-width: 850px;
    margin: 0 auto;
}

#table-of-contents {
    background-color: transparent;
    padding: 20px 0;
    margin-bottom: 40px;
    border: none;
    border-bottom: 2px solid var(--accent-color);
}

#table-of-contents h2 {
    margin-top: 0;
    text-align: center;
    border-bottom: none;
    padding-bottom: 15px;
    font-size: 1.8em;
    color: var(--accent-color);
}

#table-of-contents nav {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    gap: 15px;
    text-align: center;
}

#table-of-contents a {
    text-decoration: none;
    color: var(--primary-text);
    font-family: 'Montserrat', sans-serif;
    padding: 12px;
    border-radius: 5px;
    transition: all 0.2s ease-in-out;
    border: 1px solid transparent;
}

#table-of-contents a:hover {
    background-color: var(--surface-color);
    color: var(--accent-color);
    border-color: var(--border-color);
    transform: translateY(-2px);
    box-shadow: 0 4px 10px var(--shadow-color);
}

.encyclopedia-entry {
    background-color: var(--surface-color);
    padding: 30px 40px;
    margin-bottom: 30px;
    border: 1px solid var(--border-color);
    border-radius: 8px;
    box-shadow: 0 6px 15px var(--shadow-color);
}

.encyclopedia-entry h2 {
    margin-top: 0;
    margin-bottom: 20px;
    color: var(--accent-color);
    font-size: clamp(1.6rem, 1.4rem + 1.2vw, 2.2rem);
    border-bottom: 1px solid var(--border-color);
    padding-bottom: 10px;
}

.encyclopedia-entry img {
    max-width: 100%;
    height: auto;
    border-radius: 8px;
    margin: 15px 0;
    display: block;
}

dl dt {
    font-weight: bold;
    color: #343a40;
    margin-top: 15px;
}

dl dd {
    margin-left: 20px;
    margin-bottom: 10px;
    color: var(--secondary-text);
}

footer {
    text-align: center;
    padding: 30px;
    margin-top: 40px;
    font-size: 0.9em;
    color: var(--secondary-text);
}

.back-to-top {
    position: fixed;
    bottom: 30px;
    right: 30px;
    display: none;
    background-color: var(--accent-color);
    color: white;
    padding: 10px 18px;
    border-radius: 50%;
    text-decoration: none;
    font-size: 24px;
    box-shadow: 0 4px 8px rgba(0,0,0,0.2);
    transition: all 0.3s ease;
}

.back-to-top:hover {
    background-color: #2c4770; /* Un azul un poco más oscuro */
    transform: scale(1.1) translateY(-2px);
}

