import { Ha90TemplatePage } from './app.po';

describe('Ha90 App', function() {
  let page: Ha90TemplatePage;

  beforeEach(() => {
    page = new Ha90TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
