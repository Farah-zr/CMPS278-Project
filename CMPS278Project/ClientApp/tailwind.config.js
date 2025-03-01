/** @type {import('tailwindcss').Config} */
module.exports = {
  corePlugins: {
    preflight: false,
  },
  important: "#root",
  content: ["./src/**/*.{js,jsx,ts,tsx}"],
  theme: {
    extend: {
      colors: {
        primary: "var(--primary)",
        secondary: "var(--secondary)",
        peach: "var(--peach)",
        melon: "var(--melon)",
        background: "var(--background)",
        "misty-rose": "var(--misty-rose)",
        "pale-dogwood": "var(--pale-dogwood)",
        white: "var(--white)",
        placeholder: "var(--placeholder)",
      },
    },
  },
  plugins: [],
};
