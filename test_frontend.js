const puppeteer = require('puppeteer');
const assert = require('assert');

(async () => {
  const browser = await puppeteer.launch();
  const page = await browser.newPage();
  const errors = [];

  page.on('console', msg => {
    if (msg.type() === 'error') errors.push(msg.text());
  });
  page.on('pageerror', err => errors.push(err.message));

  try {
    await page.goto('https://harsh-91221.github.io/GlideGear/', { waitUntil: 'networkidle2' });
    await new Promise(r => setTimeout(r, 2000));
    const title = await page.title();
    console.log('Page title:', title);
    const url = page.url();
    console.log('Current URL:', url);
    if (!url.includes('github.io')) {
      console.error('Redirect occurred!');
      process.exit(1);
    }
    if (errors.length > 0) {
      console.error('Console errors:', errors);
      process.exit(1);
    }
    // Check for React root
    const root = await page.$('#root');
    if (!root) {
      console.error('React root element not found');
      process.exit(1);
    }
    console.log('Frontend loaded successfully');
  } catch (err) {
    console.error('Test failed:', err.message);
    process.exit(1);
  } finally {
    await browser.close();
  }
})();