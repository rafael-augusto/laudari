import { browser, element, by } from 'protractor';

export class LaudariApp {
  navigateTo() {
    return browser.get('/');
  }

    getParagraphText() {
    return element(by.css('.logo-font')).getText();
  }
}
