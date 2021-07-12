import { LaudariApp } from './app.po';

describe('ng-demo App', () => {
  let page: LaudariApp;

  beforeEach(() => {
    page = new LaudariApp();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toContain('conduit');
  });
});
