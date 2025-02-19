/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/**/*.{js,jsx,ts,tsx}"],
  theme: {
    extend: {
      colors: {
        primary: "var(--primary)",
        secondary: "var(--secondary)",
        peach: "var(--peach)",
        background: "var(--background)",
        "pale-dogwood": "var(--pale-dogwood)",
        white: "var(--white)",
        placeholder: "var(--placeholder)",
      },
    },
  },
  plugins: [],
};
